var render = function render() {
    ReactDOM.render(React.createElement("div", null, React.createElement('pre', null, new Date().toLocaleTimeString())), document.getElementById('CarbonClock'));
};

setInterval(render, 1000);