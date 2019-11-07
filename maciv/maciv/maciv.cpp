#include <iostream>
using namespace std;

int main()
{
	const int el = 4;
	setlocale(LC_ALL, "");
	int mass[] = { 1,2,3,4,5 };
	cout << mass[0];
	int size = sizeof(mass) / sizeof(mass[0]);
	cout << size << endl;
	char mass1[] = { 'h','e' };
	char mass2[] = "heloo world";
	for (int i : mass)
	{
		cout << mass[i] << endl;
	}


}
