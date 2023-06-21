const nums = [];
let result = '';

for (let i = 0; i < 4; i++) {
    const line = readline();
    if (result) result += '\n';
    result += line;
    nums.push(...(line.match(/\d/g) || []));
}

nums.sort((a, b) => b - a);
print(result.replace(/\d/g, () => nums.pop()));