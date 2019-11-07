#include <iostream>
#include <cmath>
using namespace std;
int main()
{
	setlocale(LC_ALL, "");
	double sum = 0;
	double i, x =0;
	for (i = 154; i >= -25; i--)
	{
		sum += i;
		x--;
	}
	cout << sum/x;

	

}
