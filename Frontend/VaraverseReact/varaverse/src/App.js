import logo from './logo.svg';
import './App.css';
import React from "react";
import { Unity, useUnityContext } from "react-unity-webgl";



function App() {
  const { unityProvider } = useUnityContext({
    loaderUrl: "Build/WebBuild.loader.js",
    dataUrl: "Build/WebBuild.data",
    frameworkUrl: "Build/WebBuild.framework.js",
    codeUrl: "Build/WebBuild.wasm",
  });
  return (
    <div className="App">
      
        
        <Unity style={{width: '90%',height: '100%', justifySelf: 'center' }} unityProvider={unityProvider}/>
    </div>
  );
}

export default App;
