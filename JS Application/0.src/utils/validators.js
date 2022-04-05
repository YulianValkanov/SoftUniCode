

export const  albumIsInvalid=(albumdata)=>{
    const requiredFeelds=[
    'name',
    'imgUrl',
    'price',
    'releaseDate',
    'artist',
    'genre',
    'description'
    ];
    
    return requiredFeelds.some(x=>!albumdata[x])
    
    }