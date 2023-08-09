let result = 0;
const d = parseInt(readline());
console.error(d%2)
if (d % 2 == 1)   {
    result = Math.round((d-32) * (5/9));
}
else  {
    result = Math.round((9/5 * d) + 32);
}  

console.log(result);
