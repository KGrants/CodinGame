read N
declare -a myarr

for((i=0 ; i<N ; i++))
do
    read Pi
    myarr[$Pi]=0
done

myarrLength=${#myarr[@]}

if [[ $N -eq 0 ]] || [[ $myarrLength -ne $N ]]
then
    maxDiff=0
else
    maxDiff=10000000
    previous=-1
    
    for i in ${!myarr[@]}
    do
        diff=$(( $i - $previous ))
        
        if [[ $previous -ne -1 ]] && [[ $diff -lt $maxDiff ]]
        then 
            maxDiff=$(($i-$previous))
        fi
        
        previous=$i
    done
fi

echo $maxDiff