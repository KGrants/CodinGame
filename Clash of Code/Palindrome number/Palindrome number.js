const n = parseInt(readline());
if(n%2!=0 && (n.toString(2).length)%2==0){
    console.log('YES')
}
else if(n%2!=0){
    console.log('yes')
}else{
    console.log('no')
}