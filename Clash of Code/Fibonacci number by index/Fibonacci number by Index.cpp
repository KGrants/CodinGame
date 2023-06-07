#include <iostream>
#include <vector>

using namespace std;
int main()
{
	long m,i,v;
	vector<long>f={0,1};
	cin>>m;
	while(cin>>m)
	{	
		for(i=f.size();i<=m;i++)
		{
			v=f[i-2]+f[i-1];
			f.push_back(v);
		}
		cout<<f[m]<<endl;
	}
}