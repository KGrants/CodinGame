n = gets.to_i

n.times do
  a=0
  b=0
  line = gets.chomp
  while a<line.length
    if line[a] == 'f'
      b=b+1
      a=a+3
    else
      a=a+1
    end
  end
  puts b
end