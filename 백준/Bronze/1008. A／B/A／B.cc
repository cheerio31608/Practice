#include <iostream>
#include <iomanip>
using namespace std;

int main(void){
    int a, b;
    cin >> a >> b;
    cout.precision(9);
    cout << fixed << (double)a/b << endl;
    
    return 0;
}