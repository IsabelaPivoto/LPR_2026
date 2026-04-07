#include <iostream>
using namespace std;

int revertNum(int num);

int main()
{ 
cout << revertNum(1234);
 return 0;
}

int revertNum(int num){

int reverso = 0;

   while ( num != 0) {
int digito = num % 10;
    reverso = reverso * 10 + digito;
   num = num / 10;
}
return reverso;
} 
