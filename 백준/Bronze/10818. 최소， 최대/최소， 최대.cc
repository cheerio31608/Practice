#include <iostream>
using namespace std;

int main(void){
    int a;
    int max = -1000000;
    int min = 1000000;
    cin >> a;
    int array[a];
    
    for(int i=0; i<a; i++){
        cin >> array[i];
        if ( max < array[i]){
            max = array[i];
        }
        if ( min > array[i]){
            min = array[i];
        }
    }
    
    cout << min << ' ' << max << endl;
    
    return 0;   
}