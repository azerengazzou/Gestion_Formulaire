import $ from "jquery";
import React, { Component, createRef } from "react";
import ReactDOM from "react-dom";

window.jQuery = $;
window.$ = $;

require("jquery-ui-sortable");
require("formBuilder");

const formData = [
   
];
class FormBuilder extends Component {
    fb = createRef();
    componentDidMount() {
        console.log(this.fb);

        let options = {
            formData: formData,
            disabledActionButtons: ["clear", "data"],

            onSave: function (evt, formData) {
                console.log("formbuilder saved");
                console.log(formBuilder.formData);
                $(".render-wrap").formRender({ formData });
                localStorage.setItem("formData", JSON.stringify(formData));
            }
        };

        var fbEditor = this.fb.current;
        var formBuilder = $(fbEditor).formBuilder(options);
    }
    render() {
        return <div id="fb-editor" ref={this.fb} />;
    };
}
export default FormBuilder;