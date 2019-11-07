#include <cmath>
#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "");
	double x;
	int y;
	cout << ("введите массу предмета и цифру измерения \n");
	cin >> x;
	cout << "1-кг \n";
	cout << ("2-миллиграмм \n");
	cout << ("3-грамм \n");
	cout << ("4-тонна \n");
	cout << ("5-центнер \n");
	cin >> y;
	switch (y)
	{
	case 1:
		cout << (x * 1);
		break;
	case 2:
		cout << (x / 1000000);
		break;
	case 3:
		cout << (x / 1000);
		break;
	case 4:
		cout << (x * 1000);
		break;
	case 5:
		cout << (x * 100);
		break;
	default:
		cout << ("введите другие данные!!!");
		break;
	}
		
}