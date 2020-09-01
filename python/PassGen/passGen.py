from tkinter import Tk,Button,Label,Entry,messagebox
import random
import string
window=Tk()

def genPassOnlyAsciiLetter():
    window.clipboard_clear()
    letters=string.ascii_letters
    result=''.join(random.choice(letters)for i in range(10))
    lbl.configure(text=result)
    window.clipboard_append(result)
    lbl.grid(column=2,row=1)
    messagebox.showinfo('Pass Gen',"Sucefully Generated and Copied to ClipBoard")
def genPassNumAndAsci():
    window.clipboard_clear()
    letters=string.ascii_letters+string.digits
    result=''.join(random.choice(letters)for i in range(10))
    lbl.configure(text=result)
    window.clipboard_append(result)
    lbl.grid(column=2,row=2)
    messagebox.showinfo('Pass Gen',"Sucefully Generated and Copied to ClipBoard")
def genPassAll():
    window.clipboard_clear()
    letters=string.ascii_letters+string.digits+string.punctuation
    result=''.join(random.choice(letters)for i in range(10))
    lbl.configure(text=result)
    window.clipboard_append(result)
    lbl.grid(column=2,row=3)
    messagebox.showinfo('Pass Gen',"Sucefully Generated and Copied to ClipBoard")
lbl=Label(window)
window.title("Random Pass Gen and Store")
window.geometry("300x80")
gen1Btn= Button(window,text="Gen Pass Only Ascii  ",command=genPassOnlyAsciiLetter)
gen1Btn.grid(column=1,row=1)
gen2Btn=Button(window,text="Gen Pass Num&Ascii",command=genPassNumAndAsci)
gen2Btn.grid(column=1,row=2)
gen2Btn=Button(window,text="Gen Pass Ascii All      ",command=genPassAll)
gen2Btn.grid(column=1,row=3)
window.mainloop()