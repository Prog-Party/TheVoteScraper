from tkinter import *
import requests
import json

def dumpert_upvote(dumpertUrl):
    """Provide a dumpert.nl compatible url and an upvote will happen."""
    if not dumpertUrl:
        return

    header = {'User-Agent': 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.11 (KHTML, like Gecko) Chrome/23.0.1271.64 Safari/537.11',
           'Accept': 'text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8',
           'Accept-Charset': 'ISO-8859-1,utf-8;q=0.7,*;q=0.3',
           'Accept-Encoding': 'none',
           'Accept-Language': 'en-US,en;q=0.8',
           'Connection': 'keep-alive'}

    #dumpertUrl = "https://www.dumpert.nl/item/6855811_0c30d07e" # mindy
    dumpertParts = dumpertUrl.split('/')
    dumpertId = dumpertParts[-1]
    dumpertIdParts = dumpertId.split('_')
    dumpertId1 = dumpertIdParts[0]
    dumpertId2 = dumpertIdParts[1]

    print("Full Dumpert ID %s" %(dumpertId))
    print("Go scraping for dumpert ID %s _ %s" %(dumpertId1,dumpertId2))

    viewUrl = "https://legacy.dumpert.nl/mobile_api/json/viewed/%s/" %(dumpertId)
    infoUrl = "https://api-live.dumpert.nl/mobile_api/json/info/%s/" %(dumpertId)
    relatedUrl = "https://api-live.dumpert.nl/mobile_api/json/related/%s/" %(dumpertId)
    commentsUrl = "https://comments.dumpert.nl/embed/%s/%s/comments/?beta=1" %(dumpertId1, dumpertId2)
    upUrl = "https://legacy.dumpert.nl/mobile_api/json/rating/%s/up/" %(dumpertId)

    print("1. Scraping dumpert url: %s" %(dumpertUrl))
    response1 = requests.get(dumpertUrl, headers=header)
    response1.raise_for_status()
    print("Expecting output: HTML")
    print(response1.text[0:100])

    print("2. Scraping view url: %s" %(viewUrl))
    response2 = requests.get(viewUrl, headers=header)
    response2.raise_for_status()
    print("Expecting output: {\"gentime\":1572559172,\"success\":true}")
    print(response2.text[0:100])

    print("3. Scraping info url: %s" %(infoUrl))
    response3 = requests.get(infoUrl, headers=header)
    response3.raise_for_status()
    print("Expecting output: {\"gentime\":1572559172,\"items\":[{\"date\ ~")
    print(response3.text[0:100])

    print("4. Scraping related url: %s" %(relatedUrl))
    response4 = requests.get(infoUrl, headers=header)
    response4.raise_for_status()
    print("Expecting output: {\"gentime\":1572550442,\"items\":[{\"date\":\"2018-03-20T19: ~")
    print(response4.text[0:100])

    print("5. Scraping VOTE UP!! url: %s" %(upUrl))
    response5 = requests.get(upUrl, headers=header)
    response5.raise_for_status()
    print("Expecting output: {\"success\":true,\"item\":{\"id\":\"1499091_19a68307 ~")
    response_json = json.loads(response5.text)  
    print(response5.text[0:100])
    
    if not response_json["success"] and response_json["errors"][0] == "Vandaag dit item al kudos gegeven":
        raise Exception('Voting failed, {}'.format(response_json["errors"]))
    
    my_gui.set_kudos_today(response_json["item"]["stats"]["kudos_today"])
    my_gui.set_kudos_total(response_json["item"]["stats"]["kudos_total"])
    my_gui.set_views_today(response_json["item"]["stats"]["views_today"])
    my_gui.set_views_total(response_json["item"]["stats"]["views_total"])

class UpVoterGUI:
    def __init__(self, master):
        self.master = master
        master.title("The Dumpert Up Voter")
        master.geometry('600x600')
        master.minsize(600, 600)
        master.maxsize(600, 600)

        self.label = Label(master, fg = "blue",  font = "Helvetica 24 bold", text="Enter Dumpert url:")
        self.label.pack(pady = 5)

        self.url_entry = Entry(master, width = 50)
        self.url_entry.pack(pady = 30)

        self.kudos_today_label = Label(master, fg = "blue", font = "Helvetica 16 bold", text="Kudos today")
        self.kudos_today_label.pack()
        self.kudos_today_label_value = Label(master, font = "Helvetica 12 bold", text="-")
        self.kudos_today_label_value.pack()
        
        self.kudos_total_label = Label(master, fg = "blue", font = "Helvetica 16 bold",  text="Kudos total")
        self.kudos_total_label.pack()
        self.kudos_total_label_value = Label(master, font = "Helvetica 12 bold", text="-")
        self.kudos_total_label_value.pack()

        self.views_today_label = Label(master, fg = "blue", font = "Helvetica 16 bold", text="Views today")
        self.views_today_label.pack()
        self.views_today_label_value = Label(master, font = "Helvetica 12 bold", text="-")
        self.views_today_label_value.pack()

        self.views_total_label = Label(master, fg = "blue", font = "Helvetica 16 bold", text="Views total")
        self.views_total_label.pack()
        self.views_total_label_value = Label(master, font = "Helvetica 12 bold", text="-")
        self.views_total_label_value.pack()

        self.greet_button = Button(master, font = "Helvetica 16 bold", text = "Vote UP!", bg = "#007acc", command = lambda: dumpert_upvote(self.url_entry.get()), height = 3, width = 20)
        self.greet_button.pack(pady = 12)

        self.close_button = Button(master, text="Close", command = master.quit, height = 3, width = 15)
        self.close_button.pack()
    
    def set_kudos_today(self, kudos_today):
        self.kudos_today_label_value.configure(text = kudos_today)

    def set_kudos_total(self, kudos_total):
        self.kudos_total_label_value.configure(text = kudos_total)

    def set_views_today(self, views_today):
        self.views_today_label_value.configure(text = views_today)

    def set_views_total(self, views_total):
        self.views_total_label_value.configure(text = views_total)

if __name__ == '__main__':
    root = Tk()
    my_gui = UpVoterGUI(root)
    root.mainloop()