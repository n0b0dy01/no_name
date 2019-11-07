#include <iostream>
#include <cmath>
using namespace std;
int main()
{
	setlocale(LC_ALL, "");
	double x = 1;
	double y = 2;
	double z = 1;
	double i = 1;
	cout << ("введите число X:");
	cin >> x;
	for (int i = 1; i <= 64; i++);
	{
		z = z * x - pow(y, i);
			i++;

	}
	cout << z;

}
// x=21
//y=2
//(x-y)
//(x-2*y)
//(x-4*y)
//z *= (x - (2 * y));
//y = y * 2;
//i++;