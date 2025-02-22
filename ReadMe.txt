Joe Loparco assignment # 1
Note for all aspects of this project involving UI i used the newer and more Robust TextMeshPro. 
documentation can be found here: 
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/index.html
Beyond this the other key differences between my implementation and the book's is the difference in how we detect apples and how we eliminate baskets. I leveraged a missedApples variable in score counter and simply imported the associated score counter game object when ever I needed to reference the amount of apples missed(like when removing a basket or moving to end game scene, or eating a poison apple as this was equivalent to missing an apple). I also leveraged this variable to track when we destroy baskets. My approach for this was to create an array of baskets and fill it up with all baskets in the game scene each time we detect an apple missed this way we potentially avoid referencing baskets we may have destroyed. Another difference between my implementation and the books is the way in which we account for poison apples as I just increment missed apples because as I stated earlier I opted for a simpler more object- oriented approach. 

