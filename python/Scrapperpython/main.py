from selenium import webdriver
from selenium.webdriver import ActionChains
import time
def findInformation(frease):
    file1="website.txt"
    f=open(file1,'a')
    website=[]
    address=[]
    browser=webdriver.Chrome('C:\Program Files (x86)\Google\Chrome\Application\87.0.4280.88\chromedriver')
    browser.get('https://www.google.pl/maps/@49.9100706,22.3449933,8z')
    search_text=browser.find_element_by_name('q')
    search_text.send_keys(frease)
    time.sleep(4)
    btn_search=browser.find_element_by_id('searchbox-searchbutton')
    btn_search.click()
    time.sleep(4)
    for strona in range(1,12):
        print("strona ",strona)
        try:
            for i in range(1,22):
                iter="//div[@data-result-index='"+str(i)+"']"
                print(i)
                click_on_result=browser.find_element_by_xpath(iter) #tylko petla dla data result index
                click_on_result.click()
                time.sleep(4)
                for x in range(1,21):
                    try:
                        get_website=browser.find_element_by_xpath('//*[@id="pane"]/div/div[1]/div/div/div['+str(x)+']/button/div[1]/div[2]/div[1]')
                        tmp=str(get_website.text)
                        if(tmp.endswith('.pl') or tmp.endswith('.com')):
                            f.write(tmp+'\n')                            
                    except:
                        pass
                mouse_back=browser.find_element_by_xpath("//span[contains(.,'Torna ai risultati')]")
                mouse_back.click()
                time.sleep(4)

        except:
            print('nastepna strona')
            back=browser.find_element_by_xpath('//*[@id="n7lv7yjyC35__section-pagination-button-next"]')
            back.click()
            time.sleep(4)
    f.close()
findInformation("firmy informatyczne")