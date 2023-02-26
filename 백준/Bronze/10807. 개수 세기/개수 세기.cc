#include <iostream>
using namespace std;

int n, v;
int arr[101];

int main()
{
    int n, v;
    int op = 0;
    int arr[101];
	cin >> n;
	for (int i = 0; i < n; i++) 
        cin >> arr[i];
	cin >> v;
	for (int i = 0; i < n; i++) 
		if (arr[i] == v) 
            op++;
	cout << op << endl;
}