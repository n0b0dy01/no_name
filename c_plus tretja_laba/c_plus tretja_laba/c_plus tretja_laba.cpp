#include <cmath>
#include <iostream>
using namespace std;

void odin();
void dwa(double a,double b,double c);
double tri(double a, double b, double c);
int main()
{
	setlocale(LC_ALL, "");
	double x, y, z;
	cout << "введите 6 чисел" << endl;
	cin >> x >> y >> z;
	cout << endl;
	 odin();
	 cout << endl;
	 dwa(x,y,z);
	 cout << endl;
	 cout << tri(x, y, z);
	

}
void odin()
{
	double a, b, c;
	cin >> a >> b >> c;
	cout << (tan(b) - c * 23) / (2 * a - 1);
}

void dwa(double a, double b, double c)
{
	cout << (tan(b) - c * 23) / (2 * a - 1);
}

double tri(double a, double b, double c)
{
	double sum;
	sum = (tan(b) - c * 23) / (2 * a - 1);
	return sum;
}