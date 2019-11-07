#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	setlocale(LC_ALL, "");
	cout << "введите число x: ";
	double x;
	cin >> x;
	double output = 1;
	double i;
	for (i = 1; i <= 64; i *= 2);
	output *= x - 1;
	for (i = 1; i <= 63; i += 2);
	output /= (x - i);
	cout << output;

}

