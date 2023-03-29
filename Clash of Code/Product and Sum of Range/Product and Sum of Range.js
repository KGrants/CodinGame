const N = parseInt(readline());

let sum = 1
let product = 1

for (let i = 1; i <= N ; i++) {
    sum += i
    product *= i
}
console.log(product);
console.log(sum - 1);