H = gets.to_i
W = gets.to_i
b=nil
G=H.times.map{|y|
    r=gets.chomp.chars
    W.times{|x|
        b=[x,y]if r[x]==?B
    }
    r
}

A=[]
if b
    [[b[0]+1,b[1]],[b[0]-1,b[1]],[b[0],b[1]+1],[b[0],b[1]-1],].each{|x,y|
        A<<G[y][x] if x>=0&&x<W&&y>=0&&y<H&&G[y][x]!=?*
    }
end

L={
    "K" => "KITCHEN",
    "T" => "BATHROOM",
    "L" => "LIVING ROOM",
    "E" => "BEDROOM",
    "C" => "CORRIDOR",
}

puts A==[] ? "BRIAN IS NOWHERE" : "BRIAN IS IN THE #{L[A[0]]}"
