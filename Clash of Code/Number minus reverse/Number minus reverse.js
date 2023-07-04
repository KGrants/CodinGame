const n = parseInt(readline());
const reverse = n.toString().split('').reverse().join('')
console.log(Number(n) - Number(reverse))