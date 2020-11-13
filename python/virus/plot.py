import influence as dane
import CV as virus
import matplotlib.pyplot as plt
import numpy as np
name=['alanina','arginina','kwas_asparaginowy','asparagina','cysteina','kwas_glutaminowy','glutamina','glicyna','histydyna','izoleucyna','leucyna','lizyna','metionina_start','fenyloalanina','prolina','seryna','treonina','tryptofan','tyrozyna','walina','stop']
influenze_virus=dane.dane
cv_virus=virus.dane
h_genome=[43357293, 50984502, 23291302, 40011221, 35237165, 37611786, 39824737, 53100700, 33890991, 59467327, 111430220, 58912095, 18508697, 59533670, 52685903, 91206795, 51281166, 18881684, 32031276, 51388556, 53801262]

print('h_genomoe-influenze')
for i in range(21):
        print(name[i],round((100*h_genome[i]/sum(h_genome))-(100*influenze_virus[i]/sum(influenze_virus)),1))
       
for i in range(21):
        
        print(name[i],round((100*h_genome[i]/sum(h_genome))-(100*cv_virus[i]/sum(cv_virus)),1))


fig1, ax1 = plt.subplots()
ax1.pie(influenze_virus, labels=name, autopct='%1.1f%%',
         shadow=False, startangle=90)
ax1.axis('equal') 
fig1.canvas.set_window_title('influence')

fig2, ax2 = plt.subplots()
ax2.pie(cv_virus, labels=name, autopct='%1.1f%%',
        shadow=False, startangle=90)
ax2.axis('equal') 
fig2.canvas.set_window_title('CV')

fig3, ax3 = plt.subplots()
ax3.pie(h_genome, labels=name, autopct='%1.1f%%',
        shadow=False, startangle=90)
ax3.axis('equal') 
fig3.canvas.set_window_title('Human Genome')
plt.show()
    
