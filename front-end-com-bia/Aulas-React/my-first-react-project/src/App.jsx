import { useState } from "react";
import reactLogo from "./assets/react.svg";
import viteLogo from "/vite.svg";
import HomePage from "./pages/HomePage";
import AboutPage from "./pages/AboutMePage";
import SkillsPage from "./pages/SkillsPage";
import ContactPage from "./pages/ContactPage";
import NavBar from "./components/NavBar";

// function App() { Formato de declaração padrão do React
const App = () => {
  return (
    <div>
      <NavBar />
      <HomePage />
      <AboutPage />
      <SkillsPage />
      <ContactPage />
    </div>
  );
};

export default App;
