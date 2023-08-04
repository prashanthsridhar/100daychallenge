public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if(n==0)
        return true;
        int count=0;

            if(flowerbed.Length==1 && flowerbed[0]==0)
                count++;
                if(flowerbed.Length==2 && flowerbed[0]==0 &&flowerbed[1]==0)
                count++;
            if(flowerbed.Length>2&&flowerbed[0]==0&&flowerbed[1]==0)
            {
                flowerbed[0]=1;
                count++;
            }
            if(flowerbed.Length>2 &&flowerbed[flowerbed.Length-1]==0&&flowerbed[flowerbed.Length-2]==0)
            {
                flowerbed[flowerbed.Length-1]=1;
                count++;
            }
            if(count>=n)
            return true;
            for(int i=0;i<flowerbed.Length-2;i++)
            {
                if (flowerbed[i] == 0 && flowerbed[i + 1] == 0 && flowerbed[i + 2] == 0)
                {
                    count++;
                    flowerbed[i+1]=1;
                    if(count>=n)
                        return true;
                }
                    
            }
            return false;
    }
}
