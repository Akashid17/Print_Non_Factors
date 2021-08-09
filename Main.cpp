
#include<iostream>

using namespace std;

class ArithmeticX
{
    public:
        void NonFactor(int);
};

void ArithmeticX::NonFactor(int iNo)
{
    if(iNo < 0)
    {
        iNo = -iNo;
    }

    for(int i = 2; i < iNo; i++)
    {
        if(iNo % i != 0)
        {
            cout<<i<<" ";
        }
    }
    cout<<endl;
}

int main()
{
    int iValue = 0;

    cout<<"Enter Number\n";
    cin>>iValue;

    ArithmeticX aobj;
    aobj.NonFactor(iValue);

    return 0;
}