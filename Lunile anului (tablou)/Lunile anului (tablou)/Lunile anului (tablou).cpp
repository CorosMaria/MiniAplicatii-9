// Lunile anului (tablou).cpp : main project file.

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{	int n;
	string luni[12]={"ianuarie", "februarie", "martie", "aprilie", "mai", "iunie", "iulie",
"august", "septembrie", "octombrie", "noiembrie", "decembrie"};
cout<<"Introduceti numarul lunii (0-12) si programul va afisa numele acesteia:";
cin>>n;
if(n > 0 && n <13)
{
	cout <<"\n\tLuna introdusa este : "  << luni[n-1];
}
cin.ignore();
cin.get();
  
    return 0;
}
