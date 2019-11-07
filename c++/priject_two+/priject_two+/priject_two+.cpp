#include <cmath>
#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "");
	double a,b,c,k;
	float e = 2.71;
	cout << ("введите a,b,c,k \n");
	cin >> a >> b >> c >> k;
	if (k == 0)
	{
		cout << ("ответ: ");
		cout << (log(a/b));
	}
	else
	if (k == 1)
	{
		cout << ("ответ: ");
		cout << (pow(e,a*b));
	}
	else
	if (k==2)
	{
		cout << ("ответ: ");
		cout << (sqrt(abs(pow(a+b,3)+c)));
	}
	else
	{
		cout << ("введите другие числа ");
	}
}

