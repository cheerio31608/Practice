#include <iostream>
using namespace std;

int main()
{
    int a, b, c, d, e;
    
    cin >> a >> b;
    cin >> c;

    if(b + c < 60)
    {
        d = a;
        e = b + c;
    }
    else
    {
        d = (a + int((b + c) / 60)) % 24;
        e = (b + c) % 60;
    }
    
    cout << d << " " << e;
    return 0;
}