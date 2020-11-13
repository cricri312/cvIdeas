from enum import Enum
c_alanina=c_arginina=c_kwas=c_asparagina=c_cysteina=c_kwas_gluta=c_glutamina=c_glicyna=c_histydyna=c_izoleucyna=c_leucyna=c_lizyna=c_metionina_start=c_fenyloalina=c_prolina=c_seryna=c_treonina=c_tryptofan=c_tyrozyna=c_walina=c_stop=0
count=0
class genetics(Enum):
    alanina=["GCA","GCG","GCT","GCC"]
    arginina=["AGA","AGG","CGA","CGG","CGT","CGC"]
    kwas_asparaginowy=["GAT","GAC"]
    asparagina=["AAT","AAC"]
    cysteina=["TGT","TGC"]
    kwas_glutaminowy=["GAA","GAG"]
    glutamina=["CAA","CAG"]
    glicyna=["GGA","GGG","GGT","GGC"]
    histydyna=["CAT","CAC"]
    izoleucyna=["ATA","ATT","ATC"]
    leucyna=["TTA","TTG","CTA","CTG","CTT","CTC"]
    lizyna=["AAA","AAG"]
    metionina_start=["ATG"]
    fenyloalanina=["TTT","TTC"]
    prolina=["CCA","CCG","CCT","CCC"]
    seryna=["AGT","AGC","TCA","TCG","TCT","TCC"]
    treonina=["ACA","ACG","ACT","ACC"]
    tryptofan=["TGG"]
    tyrozyna=["TAT","TAC"]
    walina=["GTA","GTG","GTT","GTC"]
    stop=["TAA","TAG","TGA"]
#f=open('genome.fasta','r')
f_wynik=open('wynik.txt','w')
with open('genome.fasta') as f:
  while True:
    c = f.read(3)
    count+=1
    for en in genetics:
        if str(c) in en.value:
            if en.name=="alanina":
                c_alanina+=1
            if en.name=="arginina":
                c_arginina+=1
            if en.name=="kwas_asparaginowy":
                c_kwas+=1
            if en.name=="asparagina":
                c_asparagina+=1
            if en.name=="cysteina":
                c_cysteina+=1
            if en.name=="kwas_glutaminowy":
                c_kwas_gluta+=1
            if en.name=="glutamina":
                c_glutamina+=1
            if en.name=="glicyna":
                c_glicyna+=1
            if en.name=="histydyna":
                c_histydyna+=1
            if en.name=="izoleucyna":
                c_izoleucyna+=1
            if en.name=="leucyna":
                c_leucyna+=1
            if en.name=="lizyna":
                c_lizyna+=1
            if en.name=="metionina_start":
                c_metionina_start+=1
            if en.name=="fenyloalanina":
                c_fenyloalina+=1
            if en.name=="prolina":
                c_prolina+=1
            if en.name=="seryna":
                c_seryna+=1
            if en.name=="treonina":
                c_treonina+=1
            if en.name=="tryptofan":
                c_tryptofan+=1
            if en.name=="tyrozyna":
                c_tyrozyna+=1
            if en.name=="walina":
                c_walina+=1
            if en.name=="stop":
                c_stop+=1
            print(count) 
    if not c:
            break



#print(c_alanina+c_arginina+c_kwas+c_asparagina+c_cysteina+c_kwas_gluta+c_glutamina+c_glicyna+c_histydyna+c_izoleucyna+c_leucyna+c_lizyna+c_metionina_start+c_fenyloalina+c_prolina+c_seryna+c_treonina+c_tryptofan+c_tyrozyna+c_walina+c_stop)        
dane=[c_alanina,c_arginina,c_kwas,c_asparagina,c_cysteina,c_kwas_gluta,c_glutamina,c_glicyna,c_histydyna,c_izoleucyna,c_leucyna,c_lizyna,c_metionina_start,c_fenyloalina,c_prolina,c_seryna,c_treonina,c_tryptofan,c_tyrozyna,c_walina,c_stop]
f_wynik.write(str(dane))