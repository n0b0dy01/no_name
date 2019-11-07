

#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	setlocale(LC_ALL, "");
	double n, k;
	double s = 0;
	cout << "Введите 2 числа (n,k) "<<endl<< "n = ";
	cin >> n;
	cout << "k = ";
	cin >> k;
	s = 1 - n / (2 * 3);

	for (int i = 2; i <= k; i++)
	{
		s += pow(-1, i)*(pow(n / ((i + 1) * (i + 2)), i));

	}
	cout << "Ответ : " << s;
}

