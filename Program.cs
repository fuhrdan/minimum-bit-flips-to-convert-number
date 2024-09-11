//*****************************************************************************
//** 2220. Minimum Bit Flips to Convert Number   leetcode                    **
//*****************************************************************************


int minBitFlips(int start, int goal) {
    int xorResult = start ^ goal;  // XOR to find differing bits
    int retnum = 0;
    
    // Count the number of set bits (1s) in xorResult
    while (xorResult > 0) {
        retnum += xorResult & 1;  // Increment if the least significant bit is 1
        xorResult >>= 1;            // Shift right by 1 to check the next bit
    }
    
    return retnum;
}