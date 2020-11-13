#include <iostream>
#include <math.h>
#include <conio.h>
#include <windows.h>

using namespace std;
int main()
{ 
    int v;
char h, g;
    
    
    cout<<"Dziendobry opowiec mi o sobie....| Ile masz lat????"<<endl;
    cin>>v;
    if(v>15)cout<<"super"<<endl;
    if(v<=15)cout<<"Nie mozliwe..jestes w liceum ale idzmy dalej "<< endl;
    cout<<"DOBRA JUZ MI SIE ZNUDZILO ROZMAWIANIE......."<<endl;
    cout<<"Jaki kolor ci sie podoba z poniszych podanych????"<<endl;
    cout<<"[c]Czerwony."<<endl<<"[b]Bialy."<<endl<<"[n]Niebieski."<<endl<<"[g]Granitowy"<<endl<<"[l]Limonkowy..'Radze ci nie wybierac!'"<<endl<<"[z]Zielony"<<endl;
    cout<<"[1]Wybrany przez Ztworce programu"<<endl;
    cout<<"Wypisz twoj wybur po przez litere, w nawiasie:>> ";
    cin>>g;
    cout<<"Mam ci pomuc?????? t/n:>>";
    cin>>h;
    if(g=='c') system("color 0C");
    if(g=='b') system("color 0F");
    if(g=='n') system("color 0B");
    if(g=='g') system("color 08");
    if(g=='l') system("color 0A");
    if(g=='z') system("color 02");
    if(g=='1') system("color 9A");
     if(h=='t'){
    
    
    
    
    
    
    cout<<"Czesc jestem twojm uniwersalnem kalkulatorem"<<"...."<<endl;
{
for (int i=1; i<39;i++)cout<<"_ ";
}



  cout<<" "<<endl;
  
  cout<<"Zaczynamy: "<<endl<<"Masz mozliwosc wybrac trzy sposoby liczenia!!!"<<endl<<"Jedna jest z 1 liczba  druga z 2-woma liczbami a trzecia z 3-ma liczbami. "<<endl;  for (int o=1; o<60;o++) cout<<"*";cout<<endl;
  cout<<"Aby wbybrac jedna liczbe nacisni '2'."<<endl<<"Aby wybrac 2-wie liczby nacisni '1'."<<endl<<"Aby wybrac 3 lub wjecej liczb nacisni '3'."<<endl;
  cout<<"Wybor:>> ";
  char d;
  
  
  do{
     
       
  char wybor,j;
  cin>>wybor; 
  
   switch(wybor)
  {
    case '1':
     cout<<"Menu wyboru:"<<endl;
  cout<<"[+] Suma "<<endl;
  cout<<"[-] Roznica"<<endl;
  cout<<"[*] Iloczyn"<<endl;
  cout<<"[/] Iloraz"<<endl;
  if(wybor=='1'){   
          float a,b;   
          cout<<"Wybiesz opcje ktura chcesz: ";
          char wyb;
          cin>>wyb;
           switch(wyb){
         case '+':
              cout<<"Podaj a: ";
              cin>>a;
              cout<<"Podaj b: ";
              cin>>b;
         cout<<"a+b="<<a+b<<endl;
         break;
          case '-':
               cout<<"Podaj a: ";
              cin>>a;
              cout<<"Podaj b: ";
              cin>>b;
    cout<<"a-b="<<a-b<<endl;
    break;
    case '*':
         cout<<"Podaj a: ";
              cin>>a;
              cout<<"Podaj b: ";
              cin>>b;
    cout<<"a*b="<<a*b<<endl;
    break;
    case '/':
         cout<<"Podaj a: ";
              cin>>a;
              cout<<"Podaj b: ";
              cin>>b;
    cout<<"a/b="<<a/b<<endl;
    break;
    default:
    cout<<"Opcja '"<<wybor<<"' nie istnieje!"<<endl;
    break;}
             
             
             case '2':
             
                   
                   if(wybor=='2'){
                                  cout<<"Menu wyboru:"<<endl;
                                  cout<<"[1] Pierwiastek "<<endl;
                                  cout<<"[2] Potegowanie "<<endl;
                                  cout<<"[3] Podnoszenie do kwadratu "<<endl;
                                  cout<<"[4] Zamiana stopni ??? "<<endl;
                                  cout<<"[5] Wartosc bezwzgledna "<<endl;
                                  double w;
                                  int l;
                                  cout<<"Wybiesz opcje: ";
                                  int wybo;
                                  cin>>wybo;
                                  switch(wybo){
                                  case 1:
                                       cout<<"Podaj 1 liczbe: ";
                                       cin>>w;
                                       cout<<"pierwiastek z liczby "<<w<<" jest: "<<sqrt(w)<<endl;
                                       break;
                                  case 2:
                                       cout<<"Podaj 1 liczbe: ";
                                       cin>>w;
                                       cout<<"Podaj do ilu chcesz potegowac ";
                                       cin>>l;  
                                       cout<<"Twoja liczba "<<w<<" do potegi "<<l<<" wynosi: "<<pow(w,l)<<endl; 
                                       break; 
                                  case 3 :
                                       cout<<"Podaj 1 liczbe: ";
                                  cin>>w;
                                       cout<<"Twoja liczba do kwadratu :>> "<<pow(w,2)<<endl;
                                       break; 
                                  case 4:
                                    cout<<"Podaj stopnie celciusza:  ";
                                  cin>>w;
                                  cout<<"stopnie farenhita wynasza: "<<(l*1.8)+32<<endl;
                                       break;                                                                              
                                                              
                                   case 5: 
                                        cout<<"Podaj liczbe, z ktorej chcesz obliczyc wartosc bezwgledna: ";
                                        cin>>w;
                                        cout << "|" << w << "| = "; 
                                        if (w >= 0) cout << w << endl; 
                                        else cout << w*(-1) << endl;
                                        break;
                            
                                                               
                                                              default:
                                                               cout<<"Opcja '"<<wybo<<"' nie istnieje! "<<endl;
                                                                break; 
                                       
                                                            } 
                   case '3':
                        if(wybor=='3'){
                                       cout<<"Menu wyboru:"<<endl;
                                       cout<<"[1] Liczenie funkcj kwadratowej "<<endl;
                                       cout<<"[2] Srednia arytmetyczna "<<endl;
                                       double k,y,z,delta,x,x1,x2;
                                       cout<<"Wybiesz opcje : ";
                                       int wy;
                                       cin>>wy;
                                       switch(wy){
                                                  case 1:
                                                       cout << "Podaj a: ";
cin >>k;
if(a==0)cout<<"To nie jest funkcja kwadratowa";
else{ 
cout<< "Podaj b: ";
cin>>y;
cout<<"Podaj c: ";
cin>>z;
delta=y*y-4*k*z;
cout << "Delta wynosi: " <<delta<<endl;
cout<<" pierwiastek z delty wynosi: "<<sqrt(delta)<<endl;
if (delta<0) cout <<"Brak pierwiastkow."<<endl;
else if (delta==0)
{ 
   cout <<"Istnieje jeden  pierwiastek: "<<endl;
   x1=-y/(2*k);
   cout <<"x1 jest rowne: " <<x1<<endl;
}
else
{
            x1=(-y-sqrt(delta))/(2*k);
            x2=(-y+sqrt(delta))/(2*k);
            cout<<" Istnieja dwa podwojne pierwiastki : "<<x1<<" oraz : "<<x2<<endl;
}
}
            
                  break;
               case 2:
                    double suma=0,liczba;
                    unsigned int n;
                    cout<<"Z jakiej ilosci liczb chcesz liczyc srednia arytmetyczna: ";cin>>n;cout<<endl;
                    if(n>0) 
  {
    int i = 1;
    while(i<=n)
    {
      cout<<"Podaj "<<i++<<" liczbe: ";
      cin>>liczba;
      suma+=liczba; 
    }
    cout<<"Srednia "<<n<<" liczb wynosi: "<<suma/n<<endl;
  }
  else
  cout<<"Podales nieprawidlowa wartosc zmiennej n"<<endl;
          break;
          
          }}          
                     
                  
                                                    
                                                       
                                                  
                   
          
          }
         
         
           
      
          }
          
        
    cout<<"Kontynuacja t/n:>>";
 cin>>d; 
 if(d=='t'){cout<<"Aby wbybrac jedna liczbe nacisni '2'."<<endl<<"Aby wybrac 2-wie liczby nacisni '1'."<<endl<<"Aby wybrac 3 lub wjecej liczb nacisni '3'."<<endl;
  cout<<"Wybor:>> ";}
} 
  
}



      while (d!='n');    
}
else
cout<<"Twoja sprawa";

getch();
return 0;
}

