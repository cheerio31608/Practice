#include <iostream>
using namespace std;

int main(void){
    int a, b;
    cin >> a >> b;
    if (a > b){
        cout << ">" << endl;
    }
    if (a == b){
        cout << "==" << endl;
    }
    if (a < b){
        cout << "<" << endl;
    }
    return 0;
}