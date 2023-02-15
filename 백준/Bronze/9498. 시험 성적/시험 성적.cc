#include <iostream>
using namespace std;

int main(void){
    int score;
    cin >> score;
    if ((score < 101)&&(score > 89) ){
        cout << "A" << endl;
    }
    else if ((score < 90)&&(score > 79) ){
        cout << "B" << endl;
    }
    else if ((score < 80)&&(score > 69) ){
        cout << "C" << endl;
    }
    else if ((score < 70)&&(score > 59) ){
        cout << "D" << endl;
    }
    else {
        cout << "F" << endl;
    }
    return 0;
}