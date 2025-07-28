import "bootstrap/dist/css/bootstrap.min.css"
import React from 'react'
import { StrictMode } from 'react'
import ReactDom from 'react-dom/client'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.tsx'
import { BrowserRouter } from 'react-router-dom'

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <App />
  </StrictMode>
)