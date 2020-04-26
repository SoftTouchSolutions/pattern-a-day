#include <iostream>
#include <fstream>
#include <vector>
#include <iomanip>
 
using namespace std; 


int main(){
  ofstream fout ( "test.txt", ios::app );
  cout << "Enter details format: first_name tel>" << endl;
  char name[80],tel[80]; 
  while(true){
    cin >> name >> tel;
    if(name[0]=='e' && name[1]=='n' && name[2]=='d'){
      break;
    }
    fout << setw(15) << name << setw(11) << tel << endl;
  }
  fout.close();
}