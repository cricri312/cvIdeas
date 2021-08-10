from os import TMP_MAX
from typing import ValuesView
from PyQt5 import QtCore, QtGui, QtWidgets
from PyQt5.QtWebEngineWidgets import *
from PyQt5.QtCore import *
from PyQt5.QtGui import *
from PyQt5.QtWidgets import *
import requests
from selenium import webdriver
from selenium.webdriver import ActionChains
import time
import sys
import ntpath

class Ui_MainWindow(QMainWindow):
    def findInformation(self,frease,page,results,place,filename):
        file1=filename
        f=open(file1,'a')
        website=[]
        address=[]
        browser=webdriver.Chrome('C:\Program Files (x86)\Google\Chrome\chromedriver.exe')
        browser.implicitly_wait(3)
        browser.get(place)
        browser.find_element_by_xpath("//button[contains(@aria-label,'Acconsento')]").click()
        time.sleep(5)
        search_text=browser.find_element_by_name('q')
        search_text.send_keys(frease)
        time.sleep(4)
        btn_search=browser.find_element_by_id('searchbox-searchbutton')
        btn_search.click()
        time.sleep(4)
        pierwsze = [1,3,5,7,9,11,13,15,17,19,21,23,25,27,29,31,33,35,37,39,41]
        pierwsze_fetch=pierwsze[:results]+[66]
        for strona in range(1,page+1):
            browser.maximize_window()
            print("strona ",strona)
            try:
                for i in pierwsze_fetch:
                    iter="//*[@id='pane']/div/div[1]/div/div/div[4]/div[1]/div["+str(i)+"]/div/a"
                    print(i)
                    click_on_result=browser.find_element_by_xpath(iter) #tylko petla dla data result index
                    click_on_result.click()
                    time.sleep(4)
                    try:
                        time.sleep(1)
                        get_website=browser.find_element_by_xpath("//button[contains(@aria-label,'Sito web')]")
                        tmp=str(get_website.text)
                        f.write(tmp+'^')
                        get_website=browser.find_element_by_xpath("//button[contains(@aria-label,'Telefono')]")
                        tmp=str(get_website.text)
                        f.write(tmp+'^')
                        get_website=browser.find_element_by_xpath("//button[contains(@aria-label,'Indirizzo')]")
                        tmp=str(get_website.text)
                        f.write(tmp+'\n')
                    except:
                        pass
                    mouse_back=browser.find_element_by_xpath("//span[contains(.,'Torna ai risultati')]")
                    mouse_back.click()
                    time.sleep(4)
            except:
                print('nastepna strona')
                back=browser.find_element_by_xpath('//*[@id="ppdPk-Ej1Yeb-LgbsSe-tJiF1e"]')
                back.click()
                time.sleep(4)
        f.close()
        browser.quit()
    def setupUi(self, MainWindow):
        MainWindow.setObjectName("MainWindow")
        MainWindow.resize(870, 473)
        self.centralwidget = QtWidgets.QWidget(MainWindow)
        self.centralwidget.setObjectName("centralwidget")
        self.tabWidget = QtWidgets.QTabWidget(self.centralwidget)
        self.tabWidget.setGeometry(QtCore.QRect(0, 0, 861, 451))
        self.tabWidget.setObjectName("tabWidget")
        self.tab = QtWidgets.QWidget()
        self.tab.setObjectName("tab")
        self.label = QtWidgets.QLabel(self.tab)
        self.label.setGeometry(QtCore.QRect(10, 10, 55, 16))
        self.label.setObjectName("label")
        self.lineEdit_4 = QtWidgets.QLineEdit(self.tab)
        self.lineEdit_4.setGeometry(QtCore.QRect(80, 10, 113, 22))
        self.lineEdit_4.setText("")
        self.lineEdit_4.setObjectName("lineEdit_4")
        self.lineEdit_5 = QtWidgets.QLineEdit(self.tab)
        self.lineEdit_5.setGeometry(QtCore.QRect(510, 10, 92, 22))
        self.lineEdit_5.setText("")
        self.lineEdit_5.setObjectName("lineEdit_5")
        self.label_2 = QtWidgets.QLabel(self.tab)
        self.label_2.setGeometry(QtCore.QRect(10, 60, 55, 16))
        self.label_2.setObjectName("label_2")
        self.comboBox_3 = QtWidgets.QComboBox(self.tab)
        self.comboBox_3.setGeometry(QtCore.QRect(80, 50, 113, 22))
        self.comboBox_3.setObjectName("comboBox_3")
        self.comboBox_3.addItem("")
        self.comboBox_3.addItem("")
        self.comboBox_3.addItem("")
        self.comboBox = QtWidgets.QComboBox(self.tab)
        self.comboBox.setGeometry(QtCore.QRect(350, 10, 73, 22))
        self.comboBox.setObjectName("comboBox")
        self.comboBox.addItem("")
        self.comboBox.addItem("")
        self.comboBox.addItem("")
        self.comboBox.addItem("")
        self.comboBox.addItem("")
        self.label_3 = QtWidgets.QLabel(self.tab)
        self.label_3.setGeometry(QtCore.QRect(260, 10, 55, 16))
        self.label_3.setObjectName("label_3")
        self.label_4 = QtWidgets.QLabel(self.tab)
        self.label_4.setGeometry(QtCore.QRect(260, 50, 55, 16))
        self.label_4.setObjectName("label_4")
        self.comboBox_2 = QtWidgets.QComboBox(self.tab)
        self.comboBox_2.setGeometry(QtCore.QRect(350, 50, 73, 22))
        self.comboBox_2.setObjectName("comboBox_2")
        self.comboBox_2.addItem("")
        self.comboBox_2.addItem("")
        self.comboBox_2.addItem("")
        self.comboBox_2.addItem("")
        self.comboBox_2.addItem("")
        self.pushButton = QtWidgets.QPushButton(self.tab)
        self.pushButton.setGeometry(QtCore.QRect(510, 40, 93, 28))
        self.pushButton.setObjectName("pushButton")
        self.graphicsView = QtWidgets.QGraphicsView(self.tab)
        self.graphicsView.setGeometry(QtCore.QRect(50, 120, 761, 201))
        self.graphicsView.setObjectName("graphicsView")
        
        self.webWiew=QWebEngineView(self.tab)
        self.webWiew.setGeometry(QtCore.QRect(50, 120, 761, 201))
        self.webWiew.setObjectName("webWiew")
        self.tabWidget.addTab(self.tab, "")
        self.tab_2 = QtWidgets.QWidget()
        self.tab_2.setObjectName("tab_2")
        self.label_5 = QtWidgets.QLabel(self.tab_2)
        self.label_5.setGeometry(QtCore.QRect(20, 20, 55, 16))
        self.label_5.setObjectName("label_5")
        self.tableWidget=QTableWidget(self.tab_2)
        self.tableWidget.setGeometry(QtCore.QRect(20, 56, 801, 291))
        self.tableWidget.setRowCount(500)
        self.tableWidget.setColumnCount(3)
        self.tableWidget.setObjectName("tableWidget")
        self.label_6 = QtWidgets.QLabel(self.tab)
        self.label_6.setGeometry(QtCore.QRect(450, 10, 55, 16))
        self.label_6.setObjectName("label_6")
        self.lineEdit_6 = QtWidgets.QLineEdit(self.tab_2)
        self.lineEdit_6.setGeometry(QtCore.QRect(60, 10, 113, 22))
        self.lineEdit_6.setText("")
        self.lineEdit_6.setObjectName("lineEdit_6")
        self.pushButton_2 = QtWidgets.QPushButton(self.tab_2)
        self.pushButton_2.setGeometry(QtCore.QRect(200, 10, 93, 28))
        self.pushButton_2.setObjectName("pushButton_2")
        self.tabWidget.addTab(self.tab_2, "")
        MainWindow.setCentralWidget(self.centralwidget)
        self.statusbar = QtWidgets.QStatusBar(MainWindow)
        self.statusbar.setObjectName("statusbar")
        MainWindow.setStatusBar(self.statusbar)

        self.retranslateUi(MainWindow)
        self.tabWidget.setCurrentIndex(0)
        QtCore.QMetaObject.connectSlotsByName(MainWindow)

    def retranslateUi(self, MainWindow):
        _translate = QtCore.QCoreApplication.translate
        MainWindow.setWindowTitle(_translate("MainWindow", "Google Maps Scrapper"))
        self.label.setText(_translate("MainWindow", "Key"))
        self.label_2.setText(_translate("MainWindow", "Location"))
        self.comboBox.setItemText(0, _translate("MainWindow", "1"))
        self.comboBox.setItemText(1, _translate("MainWindow", "2"))
        self.comboBox.setItemText(2, _translate("MainWindow", "3"))
        self.comboBox_3.setItemText(0, _translate("MainWindow", "Polska"))
        self.comboBox_3.setItemText(1, _translate("MainWindow", "Włochy"))
        self.comboBox_3.setItemText(2, _translate("MainWindow", "Niemcy"))
        self.comboBox.setItemText(3, _translate("MainWindow", "4"))
        self.comboBox.setItemText(4, _translate("MainWindow", "5"))
        self.label_3.setText(_translate("MainWindow", "Results"))
        self.label_4.setText(_translate("MainWindow", "Page"))
        self.comboBox_2.setItemText(0, _translate("MainWindow", "1"))
        self.comboBox_2.setItemText(1, _translate("MainWindow", "2"))
        self.comboBox_2.setItemText(2, _translate("MainWindow", "3"))
        self.comboBox_2.setItemText(3, _translate("MainWindow", "4"))
        self.comboBox_2.setItemText(4, _translate("MainWindow", "5"))
        self.pushButton.setText(_translate("MainWindow", "Scrap!"))
        self.tabWidget.setTabText(self.tabWidget.indexOf(self.tab), _translate("MainWindow", "Scrapper"))
        self.label_5.setText(_translate("MainWindow", "File"))
        self.label_6.setText(_translate("MainWindow", "Filename"))
        self.pushButton_2.setText(_translate("MainWindow", "Browse"))
        self.tabWidget.setTabText(self.tabWidget.indexOf(self.tab_2), _translate("MainWindow", "View Results"))
        self.webWiew.load(QtCore.QUrl('https://media.tenor.com/images/d2110c50a22020900743aaad39091499/tenor.gif'))
        
  
    def validateText(self,text):
        if(text.isnumeric()):
            return False
    def getInfoSearch(self):
        searchText=self.lineEdit_4.text()
        filename=self.lineEdit_5.text()
        if(self.validateText(searchText)==False):
            handleErro=QtWidgets.QMessageBox()
            handleErro.setText("Inserted only number, please retype")
            handleErro.exec_()
        elif(searchText =='' or filename==''):
            handleErro=QtWidgets.QMessageBox()
            handleErro.setText("Insert a word please")
            handleErro.exec_()
        else:
           page=self.comboBox_2.currentText()
           results=self.comboBox.currentText()
           polska="https://www.google.pl/maps"
           włochy="https://www.google.pl/maps/@42.4597942,12.5806978,8.19z"
           niecmy="https://www.google.it/maps/@52.1016158,9.9224369,8.92z"
           place=self.comboBox_3.currentText()
           
           
           print(filename)
           if(place=="Polska"):
               place1=polska
           elif(place=="Włochy"):
               place1=włochy
           elif(place=="Niemcy"):
               place1=niecmy

           self.findInformation(searchText,int(page),int(results),place1,filename)
           
           

    def scrapperSearch(self):
        self.pushButton.clicked.connect(self.getInfoSearch)
    def path_leaf(self,path):
        head, tail = ntpath.split(path)
        return tail
    def getfilename(self):
            file = QFileDialog.getOpenFileName(self, 'Open a file', '',
                               '')
            ntpath.basename("a\b\c")
            n=str(file)
            name=str(self.path_leaf(n))
            filename=name.split("'")[0]
            return(filename)
    def showInfo(self):
            t=[]
            filename=self.getfilename()
            file=open(filename,'r')
            count=0
            for i in file.readlines():
                t.append(i.split("^"))
                count+=1
            for i in range(0,count):
                t[i].append("null")
            for i in range(0,count):
                for x in range(0,3):
                    self.tableWidget.setItem(i,x,QtWidgets.QTableWidgetItem(str(t[i][x])))
            
        
    def viewInformation(self):
        self.pushButton_2.clicked.connect(self.showInfo)
    

if __name__ == "__main__":
    import sys
    app = QtWidgets.QApplication(sys.argv)
    MainWindow = QtWidgets.QMainWindow()
    ui = Ui_MainWindow()
    ui.setupUi(MainWindow)
    ui.scrapperSearch()
    ui.viewInformation()
    MainWindow.show()
    sys.exit(app.exec_())

