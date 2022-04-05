

export const  albumIsInvalid=(cardata)=>{
    const requiredFeelds=[
        'brand',
        'model',
        'description',
        'year',
        'imageUrl',
        'price'
      
    ];
    
    return requiredFeelds.some(x=>!cardata[x])
    
    }