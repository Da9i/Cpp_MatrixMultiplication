#include<iostream>
using namespace std;
int main()
{
	int arr[3][3], arr1[3][3], sum[3][3];
	cout << "ENTER FIRST MATRIX :" << endl;
	//entering first matrix.
	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			cin >> arr[i][j];
		}
	}
	cout << "ENTER SECOND MATRIX :" << endl;
	//entering second matrix.
	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			cin >> arr1[i][j];
		}
	}
	//calculating sum of two matrix.
	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			sum[i][j] = arr[i][j] + arr1[i][j];
		}

	}
	//displaying the resultant matrix.
	cout << "RESULTANT MATRIX :" << endl;
	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			cout << sum[i][j] << "  ";

		}
		cout << endl;
	}

	system("pause>0");
}
