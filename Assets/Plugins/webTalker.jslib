mergeInto(LibraryManager.library, {
  Setvar: function (val,profit) {
    this.Score = val;
	this.Profit = profit;
	window.top.postMessage({'happiness':val},"*");
	window.top.postMessage({'profit': profit},"*");
	console.log(val);
  },
  Getvar: function () {
    return this.Score;
  },
});