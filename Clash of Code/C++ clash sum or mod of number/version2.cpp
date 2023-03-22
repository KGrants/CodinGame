#include <iostream>
int main(){int n,m,s,r;std::cin>>n;s=n;if(n<10)std::cout<<n%2;else{while(s>9){n=s;s=0;while(n>0){m=n%10;s=s+m;n=n/10;}}std::cout<<s;}}