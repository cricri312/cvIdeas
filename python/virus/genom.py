f=open('genome.fna','r')
f2=open('genome.fasta','w')
for x in f:
    x=x.replace('\n','')
    f2.write(x)
f.close()
