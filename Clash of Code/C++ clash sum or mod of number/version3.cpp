#include <iostream>
using namespace std;
int main()
{int a,t,l;cin>>a;l=a;
while(a>9){t=0;for(auto i:to_string(a))t+=i-'0';a=t;}
cout<<(l>9?a:(a%2));}