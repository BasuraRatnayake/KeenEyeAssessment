async function getAnimeQuotes() {
  return await fetch("https://animechan.xyz/api/quotes/anime?title=naruto")
    .then((response) => response.json())
    .then((quotes) => console.log(quotes));
}
