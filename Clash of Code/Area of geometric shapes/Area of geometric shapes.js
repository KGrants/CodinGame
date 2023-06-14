const N = parseInt(readline());
let arr = [];
let ans = 0;
for (let i = 0; i < N; i++) {
    var inputs = readline().split(' ');
    const shapeType = inputs[0];
    const a = parseInt(inputs[1]);
    const b = parseInt(inputs[2]);
    arr.push({type:shapeType, a:a, b:b});
}
for(let i=0; i<N; i++){
    if(arr[i].type==='R'){        
        ans+=arr[i].a*arr[i].b;
    }
    if(arr[i].type==='C'){
        ans+=Math.pow(arr[i].a,2)*Math.PI;
    }
}
console.log(ans.toFixed(2));