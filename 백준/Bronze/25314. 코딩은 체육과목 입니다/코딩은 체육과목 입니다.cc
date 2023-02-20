#include <iostream>
using namespace std;

int main(void){
    int a, n;
    cin >> a;
    n = a / 4;
    for(int i=0; i<n; i++){
        cout << "long ";
    }
    cout << "int" << endl;
    return 0;
}