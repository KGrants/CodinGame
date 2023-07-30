var inputs = readline().split(' ');
let N = parseInt(inputs[0]);
let I = parseInt(inputs[1]);
let M = parseInt(inputs[2])

for(let i = 1 ; i <= M ; i++) {
    N += N * (I/100)
}
print(N)