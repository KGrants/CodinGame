const X = readline();
r="";
for (let i=0;i<X.length;i++){
    c=X.charAt(i);
    r+=c.repeat(X.slice(0,i).split(c).length)
}
console.log(r);
