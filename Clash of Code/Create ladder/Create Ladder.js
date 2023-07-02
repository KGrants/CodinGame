const floor = parseInt(readline());

console.log("#  #")
for (let i = 0; i < floor; i++) {
    console.log("####")
    if (i != floor -1) {
        console.log("#  #")
    }
}
console.log("#  #")