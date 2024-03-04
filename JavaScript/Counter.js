const createCounter = (function () {
  let counter = 0;

  return {
    makeMagic() {
      counter++;
    },

    count() {
      return counter;
    },
  };
})();
