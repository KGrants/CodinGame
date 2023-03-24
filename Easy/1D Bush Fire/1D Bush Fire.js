const N = parseInt(readline());
for (let i = 0; i < N; i++) 
{
    let a = 0;
    const line = readline();
    for (let j = 0; j < line.length; j++) 
    {
        if (line[j] == 'f')
        {
            a = a + 1;
            j = j + 2;
        }
    }
    console.log(a);
}

