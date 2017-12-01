<?php

/* calculator/index.html.twig */
class __TwigTemplate_7bf3644182d09371795b76b7d6c800d2f0742f01b60cf632112eed99549a733a extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "calculator/index.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_52c326db928656d49710bef4196f740d6fe7d744a5a6dea3415ff51ca7d8f451 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_52c326db928656d49710bef4196f740d6fe7d744a5a6dea3415ff51ca7d8f451->enter($__internal_52c326db928656d49710bef4196f740d6fe7d744a5a6dea3415ff51ca7d8f451_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "calculator/index.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_52c326db928656d49710bef4196f740d6fe7d744a5a6dea3415ff51ca7d8f451->leave($__internal_52c326db928656d49710bef4196f740d6fe7d744a5a6dea3415ff51ca7d8f451_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_6ab387220ee6daa924fa7039b82865463a5a6fd8198d7591ae29fa43e07156d7 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_6ab387220ee6daa924fa7039b82865463a5a6fd8198d7591ae29fa43e07156d7->enter($__internal_6ab387220ee6daa924fa7039b82865463a5a6fd8198d7591ae29fa43e07156d7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "    <div class=\"container body-content span=8 offset=2\">
        <div class=\"well\">
            <form class=\"form-inline\" action=\"";
        // line 6
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\" method=\"POST\">
                <fieldset>
                    <div class=\"form-group\">
                        <div class=\"col-sm-1 \">
                            <input type=\"text\" class=\"form-control\" id=\"leftOperand\" placeholder=\"Left Operand\"
                                   name=\"calculator[leftOperand]\" value=\"";
        // line 11
        echo twig_escape_filter($this->env, ((($this->getAttribute((isset($context["calculator"]) ? $context["calculator"] : null), "leftOperand", array(), "any", true, true) &&  !(null === $this->getAttribute((isset($context["calculator"]) ? $context["calculator"] : null), "leftOperand", array())))) ? ($this->getAttribute((isset($context["calculator"]) ? $context["calculator"] : null), "leftOperand", array())) : ("")), "html", null, true);
        echo "\" required>
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 \">
                            <select class=\"form-control\" name=\"calculator[operator]\">
                                <option value=\"+\" ";
        // line 18
        echo (((array_key_exists("calculator", $context) && ($this->getAttribute((isset($context["calculator"]) ? $context["calculator"] : $this->getContext($context, "calculator")), "operator", array()) == "+"))) ? ("selected") : (""));
        echo ">+</option>
                                <option value=\"-\" ";
        // line 19
        echo (((array_key_exists("calculator", $context) && ($this->getAttribute((isset($context["calculator"]) ? $context["calculator"] : $this->getContext($context, "calculator")), "operator", array()) == "-"))) ? ("selected") : (""));
        echo ">-</option>
                                <option value=\"*\" ";
        // line 20
        echo (((array_key_exists("calculator", $context) && ($this->getAttribute((isset($context["calculator"]) ? $context["calculator"] : $this->getContext($context, "calculator")), "operator", array()) == "*"))) ? ("selected") : (""));
        echo ">*</option>
                                <option value=\"/\" ";
        // line 21
        echo (((array_key_exists("calculator", $context) && ($this->getAttribute((isset($context["calculator"]) ? $context["calculator"] : $this->getContext($context, "calculator")), "operator", array()) == "/"))) ? ("selected") : (""));
        echo ">/</option>
                                <option value=\"%\" ";
        // line 22
        echo (((array_key_exists("calculator", $context) && ($this->getAttribute((isset($context["calculator"]) ? $context["calculator"] : $this->getContext($context, "calculator")), "operator", array()) == "%"))) ? ("selected") : (""));
        echo ">%</option>
                                <option value=\"^\" ";
        // line 23
        echo (((array_key_exists("calculator", $context) && ($this->getAttribute((isset($context["calculator"]) ? $context["calculator"] : $this->getContext($context, "calculator")), "operator", array()) == "^"))) ? ("selected") : (""));
        echo ">^</option>
                            </select>
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 \">
                            <input type=\"text\" class=\"form-control\" id=\"rightOperand\" placeholder=\"Right Operand\"
                                   name=\"calculator[rightOperand]\" value=\"";
        // line 31
        echo twig_escape_filter($this->env, ((($this->getAttribute((isset($context["calculator"]) ? $context["calculator"] : null), "rightOperand", array(), "any", true, true) &&  !(null === $this->getAttribute((isset($context["calculator"]) ? $context["calculator"] : null), "rightOperand", array())))) ? ($this->getAttribute((isset($context["calculator"]) ? $context["calculator"] : null), "rightOperand", array())) : ("")), "html", null, true);
        echo "\" required>
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-2 \">
                            <p>=</p>
                        </div>
                    </div>

                    ";
        // line 41
        if (array_key_exists("form", $context)) {
            // line 42
            echo "                        ";
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\FormExtension')->renderer->searchAndRenderBlock($this->getAttribute((isset($context["form"]) ? $context["form"] : $this->getContext($context, "form")), "_token", array()), 'row');
            echo "
                    ";
        }
        // line 44
        echo "
                    <div class=\"form-group\">
                        <div class=\"col-sm-4 \">
                            <input type=\"text\" class=\"form-control\" id=\"result\" placeholder=\"Result\"
                                   name=\"result\" value=\"";
        // line 48
        echo twig_escape_filter($this->env, (((array_key_exists("result", $context) &&  !(null === (isset($context["result"]) ? $context["result"] : $this->getContext($context, "result"))))) ? ((isset($context["result"]) ? $context["result"] : $this->getContext($context, "result"))) : ("")), "html", null, true);
        echo "\" readonly>
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 col-sm-offset-4\">
                            <button type=\"submit\" class=\"btn btn-primary\">Calculate</button>
                        </div>
                    </div>
                </fieldset>
            </form>
        </div>
    </div>
";
        
        $__internal_6ab387220ee6daa924fa7039b82865463a5a6fd8198d7591ae29fa43e07156d7->leave($__internal_6ab387220ee6daa924fa7039b82865463a5a6fd8198d7591ae29fa43e07156d7_prof);

    }

    public function getTemplateName()
    {
        return "calculator/index.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  120 => 48,  114 => 44,  108 => 42,  106 => 41,  93 => 31,  82 => 23,  78 => 22,  74 => 21,  70 => 20,  66 => 19,  62 => 18,  52 => 11,  44 => 6,  40 => 4,  34 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends 'base.html.twig' %}

{% block main %}
    <div class=\"container body-content span=8 offset=2\">
        <div class=\"well\">
            <form class=\"form-inline\" action=\"{{ path('index') }}\" method=\"POST\">
                <fieldset>
                    <div class=\"form-group\">
                        <div class=\"col-sm-1 \">
                            <input type=\"text\" class=\"form-control\" id=\"leftOperand\" placeholder=\"Left Operand\"
                                   name=\"calculator[leftOperand]\" value=\"{{ calculator.leftOperand ?? '' }}\" required>
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 \">
                            <select class=\"form-control\" name=\"calculator[operator]\">
                                <option value=\"+\" {{ calculator is defined and calculator.operator == '+' ? 'selected' : '' }}>+</option>
                                <option value=\"-\" {{ calculator is defined and calculator.operator == '-' ? 'selected' : '' }}>-</option>
                                <option value=\"*\" {{ calculator is defined and calculator.operator == '*' ? 'selected' : '' }}>*</option>
                                <option value=\"/\" {{ calculator is defined and calculator.operator == '/' ? 'selected' : '' }}>/</option>
                                <option value=\"%\" {{ calculator is defined and calculator.operator == '%' ? 'selected' : '' }}>%</option>
                                <option value=\"^\" {{ calculator is defined and calculator.operator == '^' ? 'selected' : '' }}>^</option>
                            </select>
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 \">
                            <input type=\"text\" class=\"form-control\" id=\"rightOperand\" placeholder=\"Right Operand\"
                                   name=\"calculator[rightOperand]\" value=\"{{ calculator.rightOperand ?? '' }}\" required>
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-2 \">
                            <p>=</p>
                        </div>
                    </div>

                    {% if form is defined %}
                        {{ form_row(form._token) }}
                    {% endif %}

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 \">
                            <input type=\"text\" class=\"form-control\" id=\"result\" placeholder=\"Result\"
                                   name=\"result\" value=\"{{ result ?? '' }}\" readonly>
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 col-sm-offset-4\">
                            <button type=\"submit\" class=\"btn btn-primary\">Calculate</button>
                        </div>
                    </div>
                </fieldset>
            </form>
        </div>
    </div>
{% endblock %}
";
    }
}
