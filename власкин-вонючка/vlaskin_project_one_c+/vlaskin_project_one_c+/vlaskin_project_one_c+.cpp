#include <iostream>
#include <cmath>
using namespace std;
int main()
{
	setlocale(LC_ALL, "");
   double c, d, a;
   cin >> c >> d >> a;
   cout << ((atan(c / 4) - d * 62) / (a * a - 1));
	
}
