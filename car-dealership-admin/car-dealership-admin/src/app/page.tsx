"use client"
import Image from "next/image";
import Navbar from "./components/Navbar";
import MainSection from "./components/ImageUploader";
import ImageUploader from "./components/ImageUploader";

export default function Home() {
  return (
  <>
    <Navbar/>
    <ImageUploader/>
  </>
  );
}
