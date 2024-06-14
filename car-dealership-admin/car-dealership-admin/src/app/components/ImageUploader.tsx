import React, { useState } from 'react'

type Image = {
  imageString: string;
}

function ImageDisplay({imageString}: Image){
  return(
    <div>
         <img src={imageString} alt={imageString}/>
    </div>
  )
}
function ImageInput(({imageHandler}: any)=> void){
  <div className=''>
        <h2>Upload Image</h2>
        <input type="file" 
        onChange={imageHandler} 
        name="file" 
        id="file" />
    </div>
}
const ImageUploader = (props: Props) => {
  const[imageUpload, setImageUpload] = useState("");
  function handleImageChange(e: any){
    setImageUpload(e.target.files[0]);
  }
    return (
    <div className=''>
       <div className=''>
        <ImageInput imageHandler={handleImageChange}/>
       </div>
       <div className=''>
        <ImageDisplay imageView={imageUpload}/>
       </div>
    </div>
  )
}

export default ImageUploader;